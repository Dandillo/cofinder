import React, { Component } from "react";
import { Route, Redirect } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import Footer from "./components/Footer";

import "./custom.css";
import projects from "./components/Projects";
import cvs from "./components/Cvs";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/clientApp" component={Home} />
        <Route exact path="/projects" component={projects} />
        <Route exact path="/cvs" component={cvs} />
        <Redirect from="/" to="/clientApp" />
      </Layout>
    );
  }
}
