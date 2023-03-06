import { Grid } from "@mui/material";
import React from "react";
import BasicCard from "./BasicCard";
const Cvs = () => {

  return (
    <div>
          <Grid container spacing={ 1}>
              <Grid item>
        <BasicCard title="Какое-то предложение"></BasicCard> </Grid>
       <Grid item> <BasicCard title="testName"></BasicCard></Grid>
        <Grid item><BasicCard title="Lorem"></BasicCard></Grid> 
              </Grid>
              
    </div>
  );
};

export default Cvs;
