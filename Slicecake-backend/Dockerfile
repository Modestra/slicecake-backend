﻿FROM mcr.microsoft.com/dotnet/aspnet:latest AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:latest AS build
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /src
COPY ["Slicecake-backend/Slicecake-backend.csproj", "Slicecake-backend/"]
COPY ["Note.Domain/Note.Domain.csproj", "Note.Domain/"]
COPY ["Slice.Persistance/Slice.Persistance.csproj", "Slice.Persistance/"]
RUN dotnet restore "Slicecake-backend/Slicecake-backend.csproj"
COPY . .
WORKDIR /src
RUN dotnet build "Slicecake-backend/Slicecake-backend.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Slicecake-backend/Slicecake-backend.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
ENV ASPNETCORE_ENVIRONMENT=Development
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Slicecake-backend.dll"]
