export const API_BASE_URL = process.env.NEXT_PUBLIC_API_URL ?? "http://localhost:5000";

export const API_ENDPOINTS = {
  health: `${API_BASE_URL}/api/health`,
  courses: `${API_BASE_URL}/api/courses`,
} as const;
