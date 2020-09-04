import React from "react";

export const Input = ({ name, value, inputName, onChange, type = "text" }) => {
  return (
    <div>
      <label>{name}</label>
      <input
        type={type}
        placeholder={`${name}...`}
        value={value}
        name={inputName}
        onChange={onChange}
      />
    </div>
  );
};
