import ResourseModel from "../Models/ResourceModel";
import GetResource from "../Http/GetResourceRequest";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";
import classes from "./Component.module.css";
import { Button } from "../../node_modules/react-bo";

const ResponseComponent = (): JSX.Element => {
  const [newRespourse, setResourse] = useState<ResourseModel>();
  useEffect(() => {
    async function init() {
      const result = await GetResource();
      setResourse(result);
    }

    init();
  }, []);

  return (
    <Card className={classes.cardStyle}>
      <h1 className={classes.header}>
        <b>Resourse</b>
      </h1>
      <div>{newRespourse?.data.name}</div>
      <div>{newRespourse?.data.year}</div>
    </Card>
  );
};

export default ResponseComponent;
