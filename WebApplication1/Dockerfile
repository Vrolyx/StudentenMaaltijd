FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 50991
EXPOSE 44376

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["WebApplication1/StudentenMaaltijd.Web.csproj", "WebApplication1/"]
COPY ["StudentenMaaltijd.InfraStructure/StudentenMaaltijd.InfraStructure.csproj", "StudentenMaaltijd.InfraStructure/"]
COPY ["StudentenMaaltijd.Entity/StudentenMaaltijd.Entity.csproj", "StudentenMaaltijd.Entity/"]
RUN dotnet restore "WebApplication1/StudentenMaaltijd.Web.csproj"
COPY . .
WORKDIR "/src/WebApplication1"
RUN dotnet build "StudentenMaaltijd.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "StudentenMaaltijd.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "StudentenMaaltijd.Web.dll"]