import UserModel from "../Models/UserModel";
import GetUser from "../Http/GetUserRequest";
import Card from "@material-ui/core/Card";
import { useState, useEffect } from "react";

const UserComponent = (): JSX.Element => {
  const [newUser, setUser] = useState<UserModel>();
  useEffect(() => {
    async function init() {
      const result = await GetUser();
      setUser(result);
    }

    init();
  }, []);

  return (
    <Card className="cardStyle">
      <div>{newUser?.data.first_name}</div>
      <div>{newUser?.data.last_name}</div>
    </Card>
  );
};

export default UserComponent;
