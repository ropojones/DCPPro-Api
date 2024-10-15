FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Ecowas.Dcppro.Web.Host/Ecowas.Dcppro.Web.Host.csproj", "src/Ecowas.Dcppro.Web.Host/"]
COPY ["src/Ecowas.Dcppro.Web.Core/Ecowas.Dcppro.Web.Core.csproj", "src/Ecowas.Dcppro.Web.Core/"]
COPY ["src/Ecowas.Dcppro.Application/Ecowas.Dcppro.Application.csproj", "src/Ecowas.Dcppro.Application/"]
COPY ["src/Ecowas.Dcppro.Core/Ecowas.Dcppro.Core.csproj", "src/Ecowas.Dcppro.Core/"]
COPY ["src/Ecowas.Dcppro.EntityFrameworkCore/Ecowas.Dcppro.EntityFrameworkCore.csproj", "src/Ecowas.Dcppro.EntityFrameworkCore/"]
WORKDIR "/src/src/Ecowas.Dcppro.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Ecowas.Dcppro.Web.Host", "src/Ecowas.Dcppro.Web.Host"]
COPY ["src/Ecowas.Dcppro.Web.Core", "src/Ecowas.Dcppro.Web.Core"]
COPY ["src/Ecowas.Dcppro.Application", "src/Ecowas.Dcppro.Application"]
COPY ["src/Ecowas.Dcppro.Core", "src/Ecowas.Dcppro.Core"]
COPY ["src/Ecowas.Dcppro.EntityFrameworkCore", "src/Ecowas.Dcppro.EntityFrameworkCore"]
WORKDIR "/src/src/Ecowas.Dcppro.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Ecowas.Dcppro.Web.Host.dll"]
