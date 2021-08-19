$('select').on('change', function () {

    let courseId = $("select#CourseId option:checked").val();

    $.ajax({
        type: "POST",
        url: "/StudentRequests/GetStudentsByCourse",
        data: { "courseId": courseId },
        success: function (students) {

            $("#students").empty();

            if (students.length !== 0) {
                showStudents(students);
            }

        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (response) {
            alert(response.responseText);
        }
    });
});

function showStudents(students) {

    $("#students").append(`
        <p>Students</p>
    `);

    $("#students").append(`
        <ul class="list-students">
        </ul>
    `);

    students.forEach((student) => {
        $(".list-students").append(`
            <li class="list-group-item">
                <label class="list-item">${student.name} ${student.surname}
                    <input type="checkbox" name="studentsId" value="${student.id}">
                </label>
            </li> 
        `);
    });
}