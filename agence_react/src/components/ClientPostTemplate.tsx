import React, { useState } from "react";
import ClientGetTemplate from "./ClientGetTemplate";

import Col from 'react-bootstrap/Col';
import Form from 'react-bootstrap/Form';
import Row from 'react-bootstrap/Row';
import Button from 'react-bootstrap/Button';
import { Container } from "react-bootstrap";

export default function ClientPostTemplate() {

    const [nom, setNom] = useState<string>();
    const [prenom, setPrenom] = useState<string>();
    const [verif, setVerif] = useState<boolean>();

    const handleSubmit = (event: any) => {
        event.preventDefault(); // prevent page refresh
        if (nom == '' || prenom == '' || /^[a-zA-Z]+$/.test(nom!) == false || /^[a-zA-Z]+$/.test(prenom!) == false) {
            setVerif(false);
        } else {
            setVerif(true);
        }
    }

    return (
        <>
            <div style={{ marginTop: '40px', marginBottom:'40px' }}>
                <Container>
                <Form onSubmit={handleSubmit}>
                        <Row>
                            <Col>
                                <Form.Control type="text" placeholder="Nom.. ahmed!" value={nom} onChange={(e: any) => setNom(e.target.value)} />
                            </Col>
                            <Col>
                                <Form.Control type="text" placeholder="Prenom.. kadri!" value={prenom} onChange={(e: any) => setPrenom(e.target.value)} />
                            </Col>
                            <Col xs="auto" className="my-1">
                                <Button type="submit">Chercher</Button>
                            </Col>
                    </Row>
                     </Form>
                </Container>
                </div>
                   
               
            <div>
                {verif == true ? (
                    <>
                        <ClientGetTemplate nom={nom!} prenom={prenom!} />
                    </>
                ): (
                <>
                    <label> Nom et prenom sont des champs obligatoire et doivent contenir seulement des character </label>
                </>
                )}
            </div>
         
        </>
    );
}