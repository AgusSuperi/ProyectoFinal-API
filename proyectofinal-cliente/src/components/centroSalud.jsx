import React from "react";
import ButtonBases from "./buttonBases";

const CentroSalud = ({ centroSalud }) => {
  return (
    <div>
      {centroSalud.nombre}
      <ButtonBases />
    </div>
  );
};

export default CentroSalud;
