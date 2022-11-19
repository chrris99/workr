FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Workr.Web/Workr.Web.csproj", "Workr.Web/"]
RUN dotnet restore "Workr.Web/Workr.Web.csproj"
COPY . .
WORKDIR "/src/Workr.Web"
RUN dotnet build "Workr.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Workr.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Workr.Web.dll"]
