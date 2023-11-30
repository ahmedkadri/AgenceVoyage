import React, { useEffect, useState } from "react";
import { IClient } from "../models/IClient";
import { IDossier } from "../models/IDossier";
import { IProduit } from "../models/IProduit";
import { useGetClient } from "../useRequest";
import ClientDetails from "./ClientDetails";

interface Iprops {
    nom: string,
    prenom: string
}

const ClientGetTemplate: React.FC<Iprops> = ({ nom, prenom }) => {

    const response: any = useGetClient(nom, prenom);

    if (response.error) return <h1>Something went wrong!</h1>;
    if (response.isLoading) return <h1>Loading...</h1>;

    const client: IClient = response.data!.client;


    if (client) {
        return (
        <div>
             <ClientDetails client={client} />
        </div>
        );
    }

    return <h1>aucun client</h1>
}
export default ClientGetTemplate