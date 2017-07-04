FROM microsoft/dotnet:1.1-runtime
LABEL maintainer="Michael Astrauckas"
WORKDIR /app
COPY out .
ENTRYPOINT ["dotnet", "hello-dotnet-core.dll"]