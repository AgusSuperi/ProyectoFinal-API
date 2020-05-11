import React from "react";
import { Route, Switch } from "react-router-dom";
import CentrosSalud from "./components/screens/centrosSalud";
import NavBar from "./components/NavBar";

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
