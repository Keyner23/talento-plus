# ---------------------------
#       BUILD
# ---------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar proyectos por separado para permitir cacheo
COPY TalentoPlus.Web/TalentoPlus.Web.csproj TalentoPlus.Web/
COPY TalentoPlus.Core/TalentoPlus.Core.csproj TalentoPlus.Core/
COPY TalentoPlus.Infrastructure/TalentoPlus.Infrastructure.csproj TalentoPlus.Infrastructure/
COPY TalentoPlus.Application/TalentoPlus.Application.csproj TalentoPlus.Application/

# Restaurar dependencias
RUN dotnet restore TalentoPlus.Web/TalentoPlus.Web.csproj

# Copiar todo el código del contexto (toda la solución)
COPY . .

# Publicar
RUN dotnet publish TalentoPlus.Web/TalentoPlus.Web.csproj -c Release -o /app/publish


# ---------------------------
#       RUNTIME
# ---------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "TalentoPlus.Web.dll"]
