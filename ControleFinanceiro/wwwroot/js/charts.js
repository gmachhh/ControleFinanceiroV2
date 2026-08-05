const financeCanvas = document.getElementById("financeChart");

if (financeCanvas) {

    new Chart(financeCanvas, {

        type: "bar",

        data: {

            labels: meses,

            datasets: [

                {

                    label: "Receitas",

                    data: receitas,

                },

                {

                    label: "Despesas",

                    data: despesas,

                }

            ]

        }

    });

}

const categoryCanvas = document.getElementById("categoryChart");

if (categoryCanvas) {

    new Chart(categoryCanvas, {

        type: "doughnut",

        data: {

            labels: categorias,

            datasets: [

                {

                    data: valores

                }

            ]

        }

    });

}