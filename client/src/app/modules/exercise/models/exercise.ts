export interface Exercise {
    id: string;
    name: string;
    description: string;
    type: string;
    muscleGroups?: string[] | null;
    icon: string;
};
