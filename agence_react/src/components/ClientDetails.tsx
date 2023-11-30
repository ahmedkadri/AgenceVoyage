import React from "react";
import { Accordion, Badge, Col, Container, Form, Row } from "react-bootstrap";
import { IClient } from "../models/IClient";
import DossierDetails from "./DossierDetails";
import ProduitDetails from "./ProduitDetails";

interface Iprops {
    client: IClient;
}

const ClientDetails: React.FC<Iprops> = ({ client }) => {
    return (
        <Container>
            <Row>
                <Col>
                    <Accordion defaultActiveKey={['0']}>
                        <Accordion.Item eventKey="0">
                            <Accordion.Header>CLIENT DETAILS #1</Accordion.Header>
                            <Accordion.Body>
                                <div>
                                    <Form.Label>NOM : <Badge bg="secondary"> {client.nom}</Badge></Form.Label><br />
                                    <Form.Label>PRENOM : <Badge bg="secondary"> {client.prenom}</Badge></Form.Label><br />
                                    <Form.Label>EMAIL : <Badge bg="secondary"> {client.email}</Badge></Form.Label><br />
                                    <Form.Label>ADRESSE : <Badge bg="secondary"> {client.adresse}</Badge></Form.Label><br />
                                    <Form.Label>DATE DE NAISSANCE : <Badge bg="secondary"> {client.dateNaissance.toString()}</Badge></Form.Label><br />
                               </div>
                        </Accordion.Body>
                         </Accordion.Item>
                    </Accordion>

                </Col>

                <Col>
                    <DossierDetails dossier={client.dossier} /><br />
                </Col>

                <Col>
                <ProduitDetails produit={client.produit} />
                </Col>

            </Row>
            </Container>
    );
}
export default ClientDetails;