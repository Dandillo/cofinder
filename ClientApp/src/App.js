import React, { Component } from "react";
import { Route, Redirect } from "react-router";
import { Layout } from "./components/Layout";
import { Home } from "./components/Home";
import Footer from "./components/Footer";

import "./custom.css";
import projects from "./components/Projects";

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path="/home" component={Home} />
        <Route exact path="/projects" component={projects} />
        <Redirect from="/" to="/home" />
      </Layout>
    );
  }
}
