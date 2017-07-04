FROM microsoft/dotnet:2.0.0-preview2-runtime
LABEL maintainer="Michael Astrauckas"
WORKDIR /app
COPY out .
ENTRYPOINT ["dotnet", "hello-dotnet-core.dll"]