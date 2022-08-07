import PostRegister from "../Http/PostRegisterRequest";
import RegisterModel from "../Models/RegisterModel";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";
import classes from "./Component.module.css";

const UserComponent = (): JSX.Element => {
  const [newRegistration, setRegistration] = useState<RegisterModel>();
  useEffect(() => {
    async function init() {
      const result = await PostRegister();
      setRegistration(result);
    }

    init();
  }, []);

  return (
    <Card className={classes.cardStyle}>
      <h1 className={classes.header}>
        <b>Register callback</b>
      </h1>
      <div>{newRegistration?.id}</div>
      <div>{newRegistration?.token}</div>
    </Card>
  );
};

export default UserComponent;
