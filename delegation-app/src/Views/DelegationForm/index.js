import React, { Component } from "react";
import { Input } from "../../Components/controllers/Input";
import { SaveDelegationItem } from "../../Services/delegationItemServiceAPI";

export default class DelegationForm extends Component {
  constructor(props) {
    super(props);

    this.state = {
      firstName: "",
      lastName: "",
      destination: "",
      date: "",
      returningData: "",
      cost: 0,
    };
  }

  submitForm = (event) => {
    event.preventDefault();
    console.log(this.state);

    SaveDelegationItem(this.state);
  };

  onInputChange = (event) => {
    const { name, value } = event.target;

    this.setState({
      [name]: value,
    });
  };

  onNumberChange = (event) => {
    const { name, value } = event.target;

    this.setState({
      [name]: Number.parseInt(value),
    });
  };

  render() {
    return (
      <article>
        <form onSubmit={this.submitForm}>
          <Input
            name="First name"
            value={this.state.firstName}
            inputName="firstName"
            onChange={this.onInputChange}
          />

          <Input
            name="Last name"
            value={this.state.lastName}
            inputName="lastName"
            onChange={this.onInputChange}
          />

          <Input
            name="Destination"
            value={this.state.destination}
            inputName="destination"
            onChange={this.onInputChange}
          />

          <Input
            type="date"
            name="Date"
            value={this.state.date}
            inputName="date"
            onChange={this.onInputChange}
          />

          <Input
            type="date"
            name="Returning Data"
            value={this.state.returningData}
            inputName="returningData"
            onChange={this.onInputChange}
          />

          <Input
            type="number"
            name="Cost"
            value={this.state.cost}
            inputName="cost"
            onChange={this.onNumberChange}
          />

          <input type="submit" />
        </form>
      </article>
    );
  }
}
