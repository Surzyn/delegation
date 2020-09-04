import React from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import { Home } from "./Views/Home";
import DelegationForm from "./Views/DelegationForm";
import { Header } from "./Components/Header";
import "./index.scss";
import DelegationList from "./Views/DelegationList";

function App() {
  return (
    <div>
      <BrowserRouter>
        <Header />
        <Switch>
          <Route exact path="/" component={Home} />
          <Route path="/form" component={DelegationForm} />
          <Route path="/list" component={DelegationList} />
        </Switch>
      </BrowserRouter>
    </div>
  );
}

export default App;
