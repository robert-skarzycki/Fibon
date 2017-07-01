FROM microsoft/dotnet:runtime

WORKDIR /dotnetapp

COPY ./Bin/Docker .

ENV ASPNETCORE_ENVIRONMENT docker

ENTRYPOINT ["dotnet", "Fibon.Api.dll"]