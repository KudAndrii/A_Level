import { config } from "../apiConfig";
import RegisterInfo from "../Models/RegisterModel";

const register = {
  email: "eve.holt@reqres.in",
  password: "pistol",
};

const Register = async (): Promise<RegisterInfo> => {
  const requestOptions = {
    method: "POST",
    headers: {
      "Content-type": "application/json",
    },
    body: JSON.stringify(register),
  };

  const response = await fetch(
    `${config.reqresUrl}/api/register`,
    requestOptions
  );

  const result = await response.json();
  return result as RegisterInfo;
};

export default Register;
