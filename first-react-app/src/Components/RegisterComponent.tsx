import PostRegister from "../Http/PostRegisterRequest";
import RegisterModel from "../Models/RegisterModel";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";

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
    <Card>
      <div>{newRegistration?.id}</div>
      <div>{newRegistration?.token}</div>
    </Card>
  );
};

export default UserComponent;
