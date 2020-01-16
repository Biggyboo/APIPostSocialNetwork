FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["APIPost/APIPost.csproj", "APIPost/"]
RUN dotnet restore "APIPost/APIPost.csproj"
COPY . .
WORKDIR "/src/APIPost"
RUN dotnet build "APIPost.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "APIPost.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "APIPost.dll"]