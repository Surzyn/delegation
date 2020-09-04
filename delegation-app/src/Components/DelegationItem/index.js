import React from "react";

export const DelegationItem = ({ id, firstName, lastName, from, to }) => {
  return <section>{`${firstName} ${lastName} ${from} ${to}`}</section>;
};
