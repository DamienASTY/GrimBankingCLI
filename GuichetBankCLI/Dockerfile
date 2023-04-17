FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GuichetBankCLI/GuichetBankCLI.csproj", "GuichetBankCLI/"]
RUN dotnet restore "GuichetBankCLI/GuichetBankCLI.csproj"
COPY . .
WORKDIR "/src/GuichetBankCLI"
RUN dotnet build "GuichetBankCLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GuichetBankCLI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GuichetBankCLI.dll"]
