import React, { Fragment } from 'react';
import './App.css';
import { BrowserRouter, Route, Routes } from "react-router-dom";
import ClientPostTemplate from './components/ClientPostTemplate';
import Header from './components/Header';
import Footer from './components/Footer';

function App() {
    return (
        <>
        <div className="App">
                <Header />
                <ClientPostTemplate />
                <Footer />
            </div>
        </>
  );
}

export default App;
