FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ArithmeticCalculator/ArithmeticCalculator.csproj ArithmeticCalculator/
COPY ArithmeticCalculator.Tests/ArithmeticCalculator.Tests.csproj ArithmeticCalculator.Tests/

RUN dotnet restore ArithmeticCalculator/ArithmeticCalculator.csproj

COPY . .

RUN dotnet publish ArithmeticCalculator/ArithmeticCalculator.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

FROM mcr.microsoft.com/dotnet/runtime:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "ArithmeticCalculator.dll"]