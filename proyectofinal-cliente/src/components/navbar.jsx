import React from "react";
import Navbar from "react-bootstrap/Navbar";
import { Link } from "react-router-dom";

const NavBar = () => {
  return (
    <Navbar bg="dark" sticky="top" variant="dark">
      <Link to="/">
        <Navbar.Brand>Centros de salud para personas asquerosas</Navbar.Brand>
      </Link>
      <Link to="/">
        <Navbar.Text className="m-2">Inicio</Navbar.Text>
      </Link>
      <Link to="/recetarios">
        <Navbar.Text className="m-2">anda tomar la leche</Navbar.Text>
      </Link>
    </Navbar>
  );
};

export default NavBar;
