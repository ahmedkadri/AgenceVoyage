import { Accordion, Badge, Form } from "react-bootstrap";
import { IDossier } from "../models/IDossier";


interface Iprops {
    dossier: IDossier;
}

const DossierDetails: React.FC<Iprops> = ({ dossier }) => {
    return (
        <>
            <Accordion defaultActiveKey={['0']}>
              <Accordion.Item eventKey="0">
                    <Accordion.Header>DOSSIER DETAILS #2</Accordion.Header>
                   <Accordion.Body>
                       <div>
                            <Form.Label>TYPE VOYAGE : <Badge bg="secondary"> {dossier.typeVoyage}</Badge></Form.Label><br />
                            <Form.Label>DATE ARRIVER : <Badge bg="secondary"> {dossier.dateArriver.toString()}</Badge></Form.Label><br />
                            <Form.Label>DUREE SEJOUR : <Badge bg="secondary"> {dossier.dureeSejour}</Badge></Form.Label><br />
                            <Form.Label>NUMERO VOL : <Badge bg="secondary"> {dossier.numeroVol} </Badge> </Form.Label><br />
                            <Form.Label>LIEU : <Badge bg="secondary"> {dossier.lieu}</Badge></Form.Label><br />
                       </div>
                   </Accordion.Body>
              </Accordion.Item>
        </Accordion>
        </>
    );
}
export default DossierDetails;