#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["inside-airbnb-restapi.csproj", "inside-airbnb-restapi/"]
RUN dotnet restore "inside-airbnb-restapi/inside-airbnb-restapi.csproj"
COPY . .
WORKDIR "/src/inside-airbnb-restapi"
RUN dotnet build "inside-airbnb-restapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "inside-airbnb-restapi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "inside-airbnb-restapi.dll"]