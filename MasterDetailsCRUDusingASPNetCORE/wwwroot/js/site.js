$(document).on('click', '.removeExperienceBtn', function () {
    $(this).closest('tr').remove();
});
$('#addExperienceBtn').click(function () {
    addExpRow();
});
function addExpRow(experience = null) {
    var experienceIndex = $('#experiencesTable tbody tr').length;
    var experienceRow = `
<tr>
<td>
<input type="hidden" name="Experiences[${experienceIndex}].ExperienceId"

value="${experience ? experience.experienceId : ''}" />

<input type="text" name="Experiences[${experienceIndex}].ExperienceTitle"

class="form-control" value="${experience ? experience.experienceTitle : ''}" />
</td>
<td>
<input type="text" name="Experiences[${experienceIndex}].InstitutionName"

class="form-control" value="${experience ? experience.institutionName : ''}" />
</td>
<td>
<input type="text" name="Experiences[${experienceIndex}].Duration"

class="form-control" value="${experience ? experience.duration : ''}" />
</td>
<td>
<button type="button" class="btn btn-danger

removeExperienceBtn">Remove</button>
</td>
</tr>
`;
    $('#experiencesTable tbody').append(experienceRow);
}
function readUrl(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#imageFile').attr('src', e.target.result).show();
        };
        reader.readAsDataURL(input.files[0]);
    }
}
