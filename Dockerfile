# Imagen base para ejecutar ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080

# Imagen para compilar
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Store_Tec_API.csproj", "."]
RUN dotnet restore "Store_Tec_API.csproj"
COPY . .
RUN dotnet build "Store_Tec_API.csproj" -c Release -o /app/build

# Publicación
FROM build AS publish
RUN dotnet publish "Store_Tec_API.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Store_Tec_API.dll"]
