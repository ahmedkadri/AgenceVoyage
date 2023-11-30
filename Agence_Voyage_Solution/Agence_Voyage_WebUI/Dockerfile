#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 2000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY Agence_Voyage_Database/Agence_Voyage_Database.csproj ./Agence_Voyage_Database/
RUN dotnet restore "Agence_Voyage_Database/Agence_Voyage_Database.csproj"

COPY Agence_Voyage_DatabaseMigrator/Agence_Voyage_DatabaseMigrator.csproj ./Agence_Voyage_DatabaseMigrator/
RUN dotnet restore "Agence_Voyage_DatabaseMigrator/Agence_Voyage_DatabaseMigrator.csproj"

COPY Agence_Voyage_Business/Agence_Voyage_Business.csproj ./Agence_Voyage_Business/
RUN dotnet restore "Agence_Voyage_Business/Agence_Voyage_Business.csproj"

COPY Agence_Voyage_WebUI/Agence_Voyage_WebUI.csproj ./Agence_Voyage_WebUI/
RUN dotnet restore "Agence_Voyage_WebUI/Agence_Voyage_WebUI.csproj"


WORKDIR /src

COPY . .

WORKDIR /src/Agence_Voyage_Database/
# Installez l'outil Entity Framework Core
RUN dotnet tool install --global dotnet-ef --version 3.1.18
# Ajoutez le chemin où l'outil est installé au PATH
ENV PATH="${PATH}:/root/.dotnet/tools"
# Appliquez les migrations
RUN dotnet ef --startup-project ../Agence_Voyage_DatabaseMigrator/ migrations add NouvelleMigration
RUN dotnet ef --startup-project ../Agence_Voyage_DatabaseMigrator/ database update


WORKDIR "/src/Agence_Voyage_WebUI/"
RUN dotnet build "Agence_Voyage_WebUI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Agence_Voyage_WebUI.csproj" -c Release -o /app/publish

WORKDIR /app


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Agence_Voyage_WebUI.dll","--environment=Development"]

WORKDIR /app
COPY ["Agence_Voyage_WebUI/AgenceVoyage.db", "./"]