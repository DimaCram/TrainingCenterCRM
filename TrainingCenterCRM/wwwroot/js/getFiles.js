$(document).ready(function () {
    getFilesByGroup();
});

$('select#GroupId').on('change', function () {
    getFilesByGroup();
});

function getFilesByGroup() {
    let groupId = $("select#GroupId option:checked").val();
    let materialId = $("#Id").val();

    $.ajax({
        type: "POST",
        url: "/Materials/GetFilesByGroup",
        data: {
            "groupId": groupId,
            "materialId": materialId
        },
        success: function (files) {

            $("#files").empty();

            if (files.length !== 0) {
                showFiles(files);
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

function showFiles(files) {

    $("#files").append(`
        <p>Files</p>
    `);

    $("#files").append(`
        <ul class="list-files">
        </ul>
    `);

    files.forEach((file) => {

        if (file.hasMaterial) {
            $(".list-files").append(`
                <li class="list-group-item">
                    <label class="list-item">${file.name}
                        <input type="checkbox" name="fileIds" value="${file.id}" checked> 
                    </label>
                </li> 
            `);
        }
        else {
            $(".list-files").append(`
                <li class="list-group-item">
                    <label class="list-item">${file.name}
                        <input type="checkbox" name="fileIds" value="${file.id}">
                    </label>
                </li> 
            `);
        }
    });
}