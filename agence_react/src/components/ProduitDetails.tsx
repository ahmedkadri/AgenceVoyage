import { Accordion, Badge, Form } from "react-bootstrap";
import { IProduit } from "../models/IProduit";

interface Iprops {
    produit: IProduit;
}

const ProduitDetails: React.FC<Iprops> = ({ produit }) => {
    return (
        <>
            <Accordion defaultActiveKey={['0']} >
                <Accordion.Item eventKey="0">
                    <Accordion.Header>PRODUIT DETAILS #3</Accordion.Header>
                    <Accordion.Body>
                        <div>
                            <Form.Label>NOM HOTEL : <Badge bg="secondary"> {produit.nomHotel}</Badge> </Form.Label><br />
                            <Form.Label>DATE ARRIVER : <Badge bg="secondary">{produit.adresse}</Badge></Form.Label><br />
                            <Form.Label>LIEU : <Badge bg="secondary">{produit.lieu}</Badge></Form.Label><br />
                            <Form.Label>NOMBRE ETOIL : <Badge bg="secondary">{produit.nombrEtoil}</Badge></Form.Label><br />
                        </div>
                    </Accordion.Body>
                </Accordion.Item>
            </Accordion>
        </>
    );
}
export default ProduitDetails;