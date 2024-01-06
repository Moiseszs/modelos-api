FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet publish -C Release -o out

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /app

COPY --from=build /app/out

ENTRYPOINT ["dotnet", "db-share.dll"]