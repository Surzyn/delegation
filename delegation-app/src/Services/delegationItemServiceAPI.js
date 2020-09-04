const BASE_URL = "https://localhost:44365/api/";

export function SaveDelegationItem(item) {
  const url = BASE_URL + "delegation";
  return fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(item),
  });
}

export function GetAllDelegations() {
  const url = BASE_URL + "delegation/base";

  return fetch(url)
    .then((response) => response.json())
    .catch((err) => console.error("cos sie wywalilo", err));
}
