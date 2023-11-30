#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 4000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src

COPY Agence_Voyage_Database/Agence_Voyage_Database.csproj ./Agence_Voyage_Database/
RUN dotnet restore "Agence_Voyage_Database/Agence_Voyage_Database.csproj"

COPY Agence_Voyage_Graphql/Agence_Voyage_Graphql.csproj ./Agence_Voyage_Graphql/
RUN dotnet restore "Agence_Voyage_Graphql/Agence_Voyage_Graphql.csproj"

WORKDIR /src

COPY . .

WORKDIR "/src/Agence_Voyage_Graphql/"
RUN dotnet build "Agence_Voyage_Graphql.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Agence_Voyage_Graphql.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Agence_Voyage_Graphql.dll","--environment=Development"]