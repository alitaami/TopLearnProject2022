#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TopLearnProject2022/TopLearnProject2022.csproj", "TopLearnProject2022/"]
COPY ["TopLearn.Core/TopLearn.Core.csproj", "TopLearn.Core/"]
COPY ["TopLearn.DataLayer/TopLearn.DataLayer.csproj", "TopLearn.DataLayer/"]
RUN dotnet restore "TopLearnProject2022/TopLearnProject2022.csproj"
COPY . .
WORKDIR "/src/TopLearnProject2022"
RUN dotnet build "TopLearnProject2022.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TopLearnProject2022.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TopLearnProject2022.dll"]