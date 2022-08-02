FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine-amd64

# Perform the health check call via curl
RUN apk --update --no-cache add curl
RUN addgroup --gid 1000 -S app && adduser --uid 1000 -S app -G app
RUN mkdir /home/app/net && chown -R app:app /home/app/net
WORKDIR /home/app/net

USER app

COPY --chown=app:app wwwroot .
COPY --chown=app:app bin/Release/net6.0/publish .

CMD ["dotnet", "WebAPITemplate.dll"]