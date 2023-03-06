import { Grid } from "@mui/material";
import React from "react";
import BasicCard from "./BasicCard";
const Projects = () => {

  return (
    <div>
      <Grid container spacing={1}>
        <Grid item>
          <BasicCard title="123"></BasicCard>
        </Grid>
        <Grid item>
          <BasicCard title="testName"></BasicCard>
        </Grid>
        <Grid item>
          <BasicCard title="Lorem"></BasicCard>
        </Grid>
      </Grid>
    </div>
  );
};

export default Projects;
