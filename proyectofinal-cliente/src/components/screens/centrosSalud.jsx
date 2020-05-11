import React, { Component } from "react";
import ButtonBases from "../buttonBases";
import Container from "@material-ui/core/Container";

class CentrosSalud extends Component {
  state = {
    centrosSalud: [],
    cargando: true,
    error: null,
  };

  componentDidMount() {
    fetch("/api/centrossalud")
      .then((res) => res.json())
      .then(
        (result) => {
          this.setState({
            cargando: false,
            centrosSalud: result,
          });
        },
        (error) => {
          this.setState({
            cargando: false,
            error,
          });
        }
      );
  }

  render() {
    const { centrosSalud, cargando, error } = this.state;

    return (
      <Container maxWidth="md">
        <ButtonBases centrosSalud={centrosSalud} />
      </Container>
    );
  }
}

export default CentrosSalud;
