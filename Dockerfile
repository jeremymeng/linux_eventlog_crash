FROM microsoft/dotnet:2.0.3-sdk-jessie
WORKDIR /hello

COPY  . ./
RUN dotnet restore -s ./nuget -s https://api.nuget.org/v3/index.json
RUN dotnet build
RUN dotnet publish --self-contained -f netcoreapp2.0 -r linux-x64 -o p

ENV COMPlus_PerfMapEnabled=1
ENV COMPlus_EnableEventLog=1

ENTRYPOINT ["p/hello", "<valid-redis-server-endpoint>", "20"]


