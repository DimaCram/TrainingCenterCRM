$(".js-studentModal").click(function () {

    let studentId = $(this).attr('data-modal');
    console.log(studentId);
    
    $.ajax({
        type: "Get",
        url: "/Students/GetStudent",
        data: {
            "id": studentId
        },
        success: function (student) {

            $(".js-body-studentModal").empty();

            if (student !== null) {
                showStudent(student);
                $("#studentModal").modal('show');
            }

        },
        failure: function (response) {
            console.log(response.responseText);
        },
        error: function (response) {
            console.log(response.responseText);
        }
    });

});

function showStudent(student) {
    $(".js-body-studentModal").append(`
        <dt class="col-sm-3">Name</dt>
        <dd class="col-sm-9">${student.name} ${student.surname}</dd>


        <dt class="col-sm-3">Age</dt>
        <dd class="col-sm-9">${student.age}</dd>
    `)
    if (student.group !== null) {
        var startDate = new Date(student.group.startDate);
        $(".js-body-studentModal").append(`

            <dt class="col-sm-3">Group</dt>
            <dd class="col-sm-9">${student.group.name}</dd>


            <dt class="col-sm-3">Start date</dt>
            <dd class="col-sm-9">${startDate.getDate()}.${startDate.getMonth()}.${startDate.getFullYear()}</dd>
        `)
    } else {
        $(".js-body-studentModal").append(`
            <dt class="col-sm-3">Group</dt>
            <dd class="col-sm-9 text-danger">Without group</dd>
        `)
    }
}