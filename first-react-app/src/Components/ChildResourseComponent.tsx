import { FC } from "react";
import DataResourse from "../Models/DataResourceModel";
import Support from "../Models/SupportModel";

type TypeForChild = {
  data: DataResourse | undefined;
  support: Support | undefined;
  statusCode: number;
};
let status: string;

const ChildResponseComponent: FC<TypeForChild> = (
  props: TypeForChild
): JSX.Element => {
  if (props.statusCode !== 404) {
    status = "";
  } else {
    status = "Status code not found: " + String(props.statusCode);
  }
  return (
    <>
      <div>{props?.data?.name}</div>
      <div>{props?.data?.year}</div>
      <div>{status}</div>
    </>
  );
};

export default ChildResponseComponent;
