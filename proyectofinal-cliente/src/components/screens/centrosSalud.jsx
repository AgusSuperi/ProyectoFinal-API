import React, { Component } from "react";
import ButtonBases from "../buttonBases";

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
      <div className="container">
        <ButtonBases centrosSalud={centrosSalud} />
      </div>
    );
  }
}

export default CentrosSalud;
