# Domain Models

## User

```json
{
    "id": "id",
    "email": "email",
    "password": "password",
    "type": "client",
    "trainerId": { "value": "trainerIdValue" },
    "gymId": { "value": "gymIdValue" },
    "accessoryIds": [
        { "value": "accessoryId1" }
    ],
    "exerciseTemplateIds": [
        { "value": "exerciseTemplateId1" },
        { "value": "exerciseTemplateId2" }
    ],
    "workoutTemplateIds": [
        { "value": "workoutTemplateId1" },
        { "value": "workoutTemplateId2" }
    ],
    "workoutIds": [
        { "value": "workoutId1" }
    ]
}
```

## Exercise
```json
{
    "id": "exerciseId", // Aggregate root
    "createdBy": "userId",
    "name": "name",
    "description": "desc",
    "type": "exerciseType",
    "difficulty": "intermediate",
    "requiredAccessoryIds": [
        { "value": "accessoryId1" }
    ],
    "targetMuscleGroups": [
        "muscleGroup1",
        "muscleGroup2",
        "muscleGroup3"
    ]
}
```

## Accessory
```json
{
    "id": "accessoryId",
    "name": "Jump rope",
    "description": "Generate jump rope description"
}
```

## Workout Template
```json
{
    "id": "workoutTemplateId",
    "createdBy": "userId",
    "name": "template name",
    "description": "description",
    "workoutSectionIds"

    "createdOnUtc": "datetime utc",
    "modifiedOnUtc": "datetime utc"
}
```

## Workout 
```json
{
    "id": "workoutId", // Aggregate root
    "name": "workout",
    "createdBy": "trainer",
    "assignedTo": [
        { "value": "userId1" }, // Workouts can only be assigned to clients or yourself
        { "value": "userId2" }
    ],
    "description": "workout description",
    "status": "inprogress",
    "workoutSectionIds": [
        { "value": "workoutSectionId1" },
        { "value": "workoutSectionId2" }
    ]
}
```

## Workout Section
```json
{
    "id": "workoutSectionId",
    "workoutId": "workoutId",
    "type": "warm up",
    "order": 1,
    "status": "completed",
    "description": "workout section description",
    "workoutItemIds" [
        { "value": "workoutItemId1" },
        { "value": "workoutItemId2" },
        { "value": "workoutItemId3" }
    ]
}
```

## Workout Block
```json
{
    "id": "workoutBlockId",
    "order": 1,
    "sets": 3,
    "status": "inprogress",
    "workoutItemIds": [
        { "value": "workoutItemId1" },
        { "value": "workoutItemId2" }
    ]
}
```

## Workout Item
```json
{
    "id": "workoutItemId",
    "exerciseId": { "value": "exerciseId" },
    "order": 1,
    "status": "inprogress", 
    "reps": 5,
    "additionalProperties": "20kg" // ??? How to implement this
}

## Gym
```json
{
    "id": "gymId",
    "name": "gym",
    "trainerIds": [
        { "value": "trainerId1" },
        { "value": "trainerId2" }
    ],
    "clientIds": [
        { "value": "clientId1" },
        { "value": "clientId2" }
    ]
}
```

TODO: Memberships, multiple gyms, gyms should have available memberships (payment structures)