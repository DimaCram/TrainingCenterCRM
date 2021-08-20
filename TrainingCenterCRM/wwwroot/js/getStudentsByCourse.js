$(document).ready(function () {
    getStudentsByCourse();
});

$('select#CourseId').on('change', function () {
    getStudentsByCourse();
});

function getStudentsByCourse() {
    let courseId = $("select#CourseId option:checked").val();
    let groupId = $("#Id").val();
        
    $.ajax({
        type: "POST",
        url: "/StudentRequests/GetStudentsByCourse",
        data: {
            "courseId": courseId,
            "groupId": groupId
        },
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
}

function showStudents(students) {

    $("#students").append(`
        <p>Students</p>
    `);

    $("#students").append(`
        <ul class="list-students">
        </ul>
    `);

    students.forEach((student) => {
        if (student.hasGroup) {
            $(".list-students").append(`
                <li class="list-group-item">
                    <label class="list-item">${student.name} ${student.surname}
                        <input type="checkbox" name="studentsId" value="${student.id}" checked>
                    </label>
                </li> 
            `);
        }
        else
        {
            $(".list-students").append(`
                <li class="list-group-item">
                    <label class="list-item">${student.name} ${student.surname}
                        <input type="checkbox" name="studentsId" value="${student.id}">
                    </label>
                </li> 
            `);
        }
    });
}