import { IDossier } from "./IDossier";
import { IProduit } from "./IProduit";

export interface IClient {
    id: number,
    nom: string,
    prenom: string,
    adresse: string,
    dateNaissance: Date,
    email: string,
    dossierId: number,
    produitId: number,
    dossier: IDossier,
    produit: IProduit
}