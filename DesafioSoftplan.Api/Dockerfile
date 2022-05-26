#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["DesafioSoftplan.Api/DesafioSoftplan.Api.csproj", "DesafioSoftplan.Api/"]
COPY ["DesafioSoftplan.Infra.Ioc/DesafioSoftplan.Infra.Ioc.csproj", "DesafioSoftplan.Infra.Ioc/"]
COPY ["DesafioSoftplan.Application/DesafioSoftplan.Services.csproj", "DesafioSoftplan.Application/"]
COPY ["DesafioSoftplan.Domain/DesafioSoftplan.Domain.csproj", "DesafioSoftplan.Domain/"]
COPY ["DesafioSoftplan.Repositories/DesafioSoftplan.Contracts.csproj", "DesafioSoftplan.Repositories/"]
COPY ["DesafioSoftplan.Infra.Context/DesafioSoftplan.Infra.Data.csproj", "DesafioSoftplan.Infra.Context/"]
RUN dotnet restore "DesafioSoftplan.Api/DesafioSoftplan.Api.csproj"
COPY . .
WORKDIR "/src/DesafioSoftplan.Api"
RUN dotnet build "DesafioSoftplan.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesafioSoftplan.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesafioSoftplan.Api.dll"]