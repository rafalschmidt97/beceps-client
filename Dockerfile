FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY Beceps.csproj .
RUN dotnet restore Beceps.csproj
COPY . .
RUN dotnet build Beceps.csproj -c Release -o /app/build
RUN dotnet publish Beceps.csproj -c Release -o /app/publish

FROM nginx:alpine AS runtime
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/Beceps/dist .
COPY nginx.conf /etc/nginx/nginx.conf
EXPOSE 80