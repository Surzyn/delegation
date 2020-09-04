import React, { Component } from "react";
import { GetAllDelegations } from "../../Services/delegationItemServiceAPI";
import { DelegationItem } from "../../Components/DelegationItem";
import { Loader } from "../../Components/Loader";

export default class DelegationList extends Component {
  constructor(props) {
    super(props);

    this.state = { items: [], isLoading: true };
  }

  componentDidMount() {
    GetAllDelegations().then((allData) => {
      this.setState({
        items: allData,
        isLoading: false,
      });
    });
  }

  render() {
    if (this.state.isLoading) {
      return <Loader />;
    }

    const allItems = this.state.items.map((item) => {
      return (
        <li key={`item-list-${item.id}`}>
          <DelegationItem
            from={item.from}
            to={item.to}
            firstName={item.firstName}
            lastName={item.lastName}
            id={item.id}
          />
        </li>
      );
    });

    return (
      <article>
        <h3>All delegations:</h3>
        <ul>{allItems}</ul>
      </article>
    );
  }
}
