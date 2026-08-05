const input = document.getElementById("searchInput");

if (input) {

    input.addEventListener("keyup", function () {

        const value = this.value.toLowerCase();

        const rows = document.querySelectorAll(".transaction-row");

        rows.forEach(row => {

            row.style.display = row.innerText
                .toLowerCase()
                .includes(value)

                ? ""

                : "none";

        });

    });

}