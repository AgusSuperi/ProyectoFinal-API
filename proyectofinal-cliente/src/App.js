import React from "react";
import { Route, Switch } from "react-router-dom";
import NavBar from "./components/navbar";
import CentrosSalud from "./components/screens/centrosSalud";

function App() {
  return (
    <React.Fragment>
      <NavBar />
      <Switch>
        <Route exact path="/" component={CentrosSalud} />
      </Switch>
    </React.Fragment>
  );
}

export default App;
